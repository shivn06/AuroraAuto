SET IDENTITY_INSERT [dbo].[Cart] ON
INSERT INTO [dbo].[Cart] ([CartID], [Quantity], [TotalPrice], [CustomerID], [ProductID]) VALUES (1, 2, 40, 1, 2)
INSERT INTO [dbo].[Cart] ([CartID], [Quantity], [TotalPrice], [CustomerID], [ProductID]) VALUES (2, 1, 150, 2, 5)
SET IDENTITY_INSERT [dbo].[Cart] OFF

SET IDENTITY_INSERT [dbo].[Category] ON
INSERT INTO [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (4, N'Chemicals')
INSERT INTO [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (5, N'Tools')
INSERT INTO [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (6, N'Brushes')
SET IDENTITY_INSERT [dbo].[Category] OFF

SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([CustomerID], [FirstName], [MiddleName], [LastName], [Address], [Phone], [Email]) VALUES (1, N'Viraj', N'Mehul', N'Mody', N'114 White Swan Road', N'0211736216', N'vmody123@gmail.com')
INSERT INTO [dbo].[Customer] ([CustomerID], [FirstName], [MiddleName], [LastName], [Address], [Phone], [Email]) VALUES (2, N'John', NULL, N'Doe', N'1 Gibbs Drive', N'0216388238', N'johndoe@gmail.com')
SET IDENTITY_INSERT [dbo].[Customer] OFF

SET IDENTITY_INSERT [dbo].[Order] ON
INSERT INTO [dbo].[Order] ([OrderID], [CustomerID], [CartID], [PaymentID]) VALUES (1, 1, 1, 1)
INSERT INTO [dbo].[Order] ([OrderID], [CustomerID], [CartID], [PaymentID]) VALUES (2, 2, 2, 2)
SET IDENTITY_INSERT [dbo].[Order] OFF

SET IDENTITY_INSERT [dbo].[Payment] ON
INSERT INTO [dbo].[Payment] ([PaymentID], [PayAmount], [PayMethod], [PayDate]) VALUES (1, CAST(40.00 AS Decimal(18, 2)), 1, N'2024-11-01 16:11:00')
INSERT INTO [dbo].[Payment] ([PaymentID], [PayAmount], [PayMethod], [PayDate]) VALUES (2, CAST(150.00 AS Decimal(18, 2)), 0, N'2024-10-10 10:17:00')
SET IDENTITY_INSERT [dbo].[Payment] OFF

SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([ProductID], [CategoryID], [ImageName], [ProductName], [Price], [Stock]) VALUES (2, 4, N'pexels-torque-detail-3806966-7154622240009964.jpg', N'Wheel Cleaning Spray', CAST(25.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([ProductID], [CategoryID], [ImageName], [ProductName], [Price], [Stock]) VALUES (3, 4, N'pexels-introspectivedsgn-4674366240209563.jpg', N'Car Wash & Shampoo', CAST(30.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([ProductID], [CategoryID], [ImageName], [ProductName], [Price], [Stock]) VALUES (4, 5, N'pexels-tima-miroshnichenko-6873101240251374.jpg', N'Foam Gun', CAST(40.00 AS Decimal(18, 2)), CAST(19.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([ProductID], [CategoryID], [ImageName], [ProductName], [Price], [Stock]) VALUES (5, 5, N'pexels-introspectivedsgn-4876676240727521.jpg', N'Power Washer', CAST(150.00 AS Decimal(18, 2)), CAST(18.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([ProductID], [CategoryID], [ImageName], [ProductName], [Price], [Stock]) VALUES (6, 6, N'pexels-tima-miroshnichenko-6873020240813202.jpg', N'Detailing Brush', CAST(7.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([ProductID], [CategoryID], [ImageName], [ProductName], [Price], [Stock]) VALUES (7, 6, N'wheel brush240844510.jpg', N'Wheel Brush', CAST(10.00 AS Decimal(18, 2)), CAST(44.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Product] OFF
