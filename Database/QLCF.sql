create table TableFood
(
id int identity primary key,
name nvarchar(100) not null default N' bàn chưa có tên',
status nvarchar(100) not null default N'Trống'
);
create table AccountType
(
id int primary key,
name nvarchar(100)
);
create table Account
(
UserName nvarchar(100) primary key,
DisplayName nvarchar(100) not null default N'User',
Password nvarchar(100) not null default 1,
Type int not null default 0 
foreign key (Type) references dbo.AccountType(id)
);
create table FoodCategory
(
id int identity primary key,
name nvarchar(100) not null default N'Chưa đặt tên'
)
create table Food
(
id int identity primary key,
name nvarchar(100) not null default N'Chưa đặt tên',
idCategory int not null,
price float not null default 0,

foreign key (idCategory) references dbo.FoodCategory(id)
);

drop table Bill
create table Bill
(
id int identity primary key,
TimeCheckIn datetime not null Default CONVERT(VARCHAR(30), GETDATE(), 120),
TimeCheckOut datetime,
discount int default 0,
idTable int not null,
status int not null default 0,
totalPrice float
foreign key (idTable) References dbo.TableFood(id)
);

drop table BillInfo
create table BillInfo
(
id int identity primary key,
idBill int not null,
idFood int not null,
count int not null default 0

foreign key (idBill) references dbo.Bill(id),
foreign key (idFood) references dbo.Food(id)
);

INSERT INTO AccountType(id, name)
VALUES(1, 'admin');

INSERT INTO AccountType(id, name)
VALUES(2, 'staff');

INSERT INTO Account(UserName, password, DisplayName,Type)
VALUES('Thanh', 'Thanh', N'Tran Thanh', 1);

INSERT INTO Account(UserName, password, DisplayName,Type)
VALUES('Binh', 'Binh', N'GBinhT', 2)

INSERT INTO Account(UserName, password, DisplayName,Type)
VALUES('Huy', 'Huy', N'Nguyen Quang Huy', 2)


 