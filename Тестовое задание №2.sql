
-- �������� ������
create table [Product] (
	id int primary key identity(1,1),
	nameProduct nvarchar(30) not null,
	descrProduct nvarchar(max)
);

create table Category (
	id int primary key identity(1,1),
	nameCategory nvarchar(30) not null,
	descrCategory nvarchar(max)
);

create table ProductsAndCategory (
	id int primary key identity(1,1),
	productId int not null,
	categoryId int not null,
	CONSTRAINT FK_Product FOREIGN KEY (productId)  REFERENCES [Product] (id),
	CONSTRAINT FK_Category FOREIGN KEY (categoryId)  REFERENCES Category (id)
);

-- ���������� ������
insert into [Product] (nameProduct, descrProduct)
values 
(N'�������', N'������'),
(N'�����', N'������'),
(N'���', N'�����������'),
(N'������', N'��������'),
(N'������', N'�������')

insert into Category (nameCategory, descrCategory)
values 
(N'�������� ���������', N'���������� ����'),
(N'������', N'������������� ����')

insert into ProductsAndCategory (productId, categoryId)
values 
(1,2), (2,2), (3,1), (4,1)

-- ���������� �������
select 
	[Product].nameProduct, 
	Category.nameCategory
from            
	ProductsAndCategory 
	right outer join [Product] on ProductsAndCategory.productId = [Product].id 
	left outer join Category on ProductsAndCategory.categoryId = Category.id