use QL_QuanCafe;
------------------------------------------------------------------------PROCEDURE-----------------------------------------------------------------
create PROCEDURE USP_Login
    @username VARCHAR(100),
    @password VARCHAR(100)
AS
BEGIN
    SELECT TOP 1 *
    FROM Account ac
    WHERE ac.username = @username AND ac.password = @password;
END;

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure USP_GetAccountByUserName
@username nvarchar(100)
as
begin
	select * from dbo.Account where UserName = @username
end;

----------------------------------------------------------------------------------------------------------------------------------------------------------

DROP PROCEDURE IF EXISTS USP_LoadTableList
CREATE PROCEDURE USP_LoadTableList
As
Begin
	SELECT * FROM TableFood;
End;

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure USP_InsertBill
@idTable int
as
begin
insert dbo.Bill(TimeCheckIn, TimeCheckOut,discount, idTable, status)
values (CONVERT(VARCHAR(30), GETDATE(), 120), null, 0, @idTable, 0)
end;

----------------------------------------------------------------------------------------------------------------------------------------------------------

create proc USP_InsertBillInfo
@idBill int, @idFood int, @count int
as
begin
	declare @isExistBillInfo int, @foodCount int = 0
	
	select @isExistBillInfo = id, @foodCount = bi.count 
	from dbo.BillInfo as bi 
	where idBill = @idBill and idFood = @idFood
	
	if(@isExistBillInfo > 0)
	Begin
		declare @newCount int = @foodCount + @count
		if(@newCount > 0)
			update dbo.BillInfo set count = @foodCount + @count where idFood = @idFood
		else
			delete dbo.BillInfo where idBill = @idBill and idFood = @idFood

	end;
	else
	begin
		if(@count > 0)
			insert dbo.BillInfo(idBill, idFood, count)
			values(@idBill, @idFood, @count)
	end
end;

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure USP_SwitchTable
@idTable1 int, @idTable2 int
as
begin
	declare @idFirstBill int, @idSecondBill int
	declare @isFirstTableEmpty int = 1, @isSecondTableEmpty int = 1


	select @idSecondBill = id from dbo.Bill where idTable = @idTable2 and status = 0 
	select @idFirstBill = id from dbo.Bill where idTable = @idTable1 and status = 0 

	if(@idFirstBill is null)
	begin
		insert dbo.Bill(TimeCheckIn, TimeCheckOut, idTable, status)
		values (CONVERT(VARCHAR(30), GETDATE(), 120), null, @idTable1, 0)
		select @idFirstBill = max(id) from dbo.Bill where idTable = @idTable1 and status = 0
	end
	select @isFirstTableEmpty = count(*) from dbo.BillInfo where idBill = @idFirstBill
	if(@idSecondBill is null)
	begin
		insert dbo.Bill(TimeCheckIn, TimeCheckOut, idTable, status)
		values (CONVERT(VARCHAR(30), GETDATE(), 120), null, @idTable2, 0)
		select @idSecondBill = max(id) from dbo.Bill where idTable = @idTable2 and status = 0
	end
	select @isSecondTableEmpty = count(*) from dbo.BillInfo where idBill = @idSecondBill

	select id into IDBillInfoTable from dbo.BillInfo where idBill = @idSecondBill

	update dbo.BillInfo set idBill = @idSecondBill where idBill = @idFirstBill
	update dbo.BillInfo set idBill = @idFirstBill where id in (select * from IDBillInfoTable)

	drop table IDBillInfoTable
	if(@isFirstTableEmpty = 0)
		update dbo.TableFood set status = N'Trống' where id = @idTable2
	if(@isSecondTableEmpty = 0)
		update dbo.TableFood set status = N'Trống' where id = @idTable1
end;

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure USP_GetListBillByDateAndPage
@checkIn datetime, @checkOut datetime, @page int
as
begin
	declare @pageRows int = 10
	declare @selectedRows int = @pageRows * @page
	declare @exceptRows int = (@page - 1) * @pageRows
		
		select t.name as [Tên bàn], b.TimeCheckIn as [Vào], b.TimeCheckOut as [Ra], b.discount as [Giảm giá(%)], b.totalPrice as[Tổng tiền(vnd)] into SortBillByTimeCheckOut
		from dbo.Bill as b, dbo.TableFood as t
		where TimeCheckIn >= @checkIn and TimeCheckOut <= @checkOut and b.status = 1 and t.id = b.idTable
		order by TimeCheckOut DESC

		select top (@selectedRows) * from SortBillByTimeCheckOut
		except
		select top (@exceptRows) * from SortBillByTimeCheckOut

		drop table SortBillByTimeCheckOut
end;

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure USP_GetNumBillByDate
@checkIn datetime, @checkOut datetime
as
begin
	select Count(*)
	from dbo.Bill as b, dbo.TableFood as t
	where TimeCheckIn >= @checkIn and TimeCheckOut <= @checkOut and b.status = 1 and t.id = b.idTable
end;

----------------------------------------------------------------------------------------------------------------------------------------------------------
  
create procedure USP_UpdateAccount
@userName nvarchar(100), @displayName nvarchar (100), @password nvarchar(100), @newPassword nvarchar(100)
as
begin
	declare @isRightPass int

	select @isRightPass = count(*) from dbo.Account where UserName = @userName and Password = @password
	if(@isRightPass = 1)
	begin
		if(@newPassword is null or @newPassword = '')
		begin
			update dbo.Account set DisplayName = @displayName where UserName = @userName	
		end
		else
			update dbo.Account set DisplayName = @displayName, Password = @newPassword where UserName = @userName
	end
end;

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure USP_SearchFoodByName
@foodName NVARCHAR(100)
as
begin
declare @fn nvarchar(100)
SELECT @fn =  dbo.non_unicode_convert(@foodName)
SELECT * FROM dbo.Food WHERE dbo.non_unicode_convert(name) LIKE  '%' + @fn + '%'
end

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure USP_GetRevenueByDate
@checkIn datetime, @checkOut datetime
as
begin	
		select sum(b.totalPrice)
		from dbo.Bill as b
		where TimeCheckIn >= @checkIn and TimeCheckOut <= @checkOut and b.status = 1 
end;

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure USP_GetBestSelling
@checkIn datetime, @checkOut datetime
as
begin
select top 1 idFood as id into Summ 
from dbo.BillInfo as bi, dbo.Bill as b
where bi.idBill = b.id and b.TimeCheckIn >= @checkIn and b.TimeCheckOut <= @checkOut and b.status = 1
group by idFood
order by SUM(count) desc

select name from Food, Summ where Food.id = Summ.id
	drop table Summ
end;

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure USP_GetNumBestSelling
@checkIn datetime, @checkOut datetime
as
begin
select top 1 SUM(count) 
from dbo.BillInfo as bi, dbo.Bill as b
where bi.idBill = b.id and b.TimeCheckIn >= @checkIn and b.TimeCheckOut <= @checkOut and b.status = 1
group by idFood
order by SUM(count) desc
end;

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure USP_GetWorstSelling
@checkIn datetime, @checkOut datetime
as
begin
select idFood as id, sum(bi.count) as sum into Summ 
from dbo.BillInfo as bi, dbo.Bill as b
where bi.idBill = b.id and b.TimeCheckIn >= @checkIn and b.TimeCheckOut <= @checkOut and b.status = 1
group by idFood 

select top 1 name from Food left outer join Summ on Food.id = Summ.id
order by sum asc
	drop table Summ
end;

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure USP_GetNumWorstSelling
@checkIn datetime, @checkOut datetime
as
begin
select idFood as id, sum(bi.count) as sum into Summ 
from dbo.BillInfo as bi, dbo.Bill as b
where bi.idBill = b.id and b.TimeCheckIn >= @checkIn and b.TimeCheckOut <= @checkOut and b.status = 1
group by idFood 


select top 1 COALESCE(sum, 0) from Food left outer join Summ on Food.id = Summ.id
order by sum asc
	drop table Summ
end;
---------------------------------------------------------------------------------TRIGGER-------------------------------------------------------------------

create trigger UTG_UdateBillInfo
on dbo.BillInfo for insert, update
as
begin
	declare @idBill int

	select @idBill = idBill From inserted

	declare @idTable int

	select @idTable = idTable from dbo.Bill where id = @idBill and status = 0

	declare @count int
	select @count = count(*) from dbo.BillInfo where idBill = @idBill

	if(@count > 0)
	begin
	update dbo.TableFood set status = N'Có người' where id = @idTable
	end
	else
	begin
		update dbo.TableFood set status = N'Trống' where id = @idTable
	end
end;	

----------------------------------------------------------------------------------------------------------------------------------------------------------

create trigger UTG_UpdateBill
on dbo.Bill for update
as
begin
	declare @idBill int

	select @idBill = id from inserted

	declare @idTable int

	select @idTable = idTable from dbo.Bill where id = @idBill
	declare @count int = 0	
	select @count = count(*) from dbo.Bill where idTable = @idTable and status = 0
	if(@count = 0)
		update dbo.TableFood set status = N'Trống' where id = @idTable
end;

----------------------------------------------------------------------------------------------------------------------------------------------------------

create trigger UTG_DeleteBillInfo
on BillInfo for delete
as
begin
	declare @idBillInfo int 
	declare @idBill int
	select @idBillInfo = id, @idBill = deleted.id from Deleted
 
	declare @idTable int 
	select @idTable = idTable from dbo.Bill where id = @idBill

	declare @count int = 0 
	select @count = count(*) from dbo.BillInfo, dbo.Bill where Bill.id = @idBill and Bill.id = BillInfo.idBill and Bill.status = 0
	if(@count = 0)
		update dbo.TableFood set status = N'Trống' where id =  @idTable
end;

---------------------------------------------------------------------------FuncTion---------------------------------------------------------------------
CREATE FUNCTION [dbo].[non_unicode_convert](@inputVar NVARCHAR(MAX) )
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
    RETURN @inputVar
END;