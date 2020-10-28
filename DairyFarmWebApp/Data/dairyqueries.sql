GO
SET IDENTITY_INSERT [dbo].[Courses] ON 
GO
INSERT [dbo].[Courses] ([CategoryID], [CategoryCode], [CategoryName]) VALUES (1, N'MK01', N'Milk')
GO
INSERT [dbo].[Courses] ([CategoryID], [CategoryCode], [CategoryName]) VALUES (2, N'BT01', N'Butter')
GO
INSERT [dbo].[Courses] ([CategoryID], [CategoryCode], [CategoryName]) VALUES (3, N'BD01', N'Bread')
GO
INSERT [dbo].[Courses] ([CategoryID], [CategoryCode], [CategoryName]) VALUES (4, N'PN01', N'Paneer')
GO
INSERT [dbo].[Courses] ([CategoryID], [CategoryCode], [CategoryName]) VALUES (5, N'SY01', N'Soya')
GO
INSERT [dbo].[Courses] ([CategoryID], [CategoryCode], [CategoryName]) VALUES (6, N'GH01', N'Ghee')
GO
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 
GO
INSERT [dbo].[Students] ([CompanyID], [CompanyName]) VALUES (1, N'Amul')
GO
INSERT [dbo].[Students] ([CompanyID], [CompanyName]) VALUES (2, N'Mother Dairy')
GO
INSERT [dbo].[Students] ([CompanyID], [CompanyName]) VALUES (3, N'Patanjali')
GO
INSERT [dbo].[Students] ([CompanyID], [CompanyName]) VALUES (4, N'Namaste India')
GO
INSERT [dbo].[Students] ([CompanyID], [CompanyName]) VALUES (5, N'Paras')
GO
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[StudentCourses] ON 
GO
INSERT [dbo].[StudentCourses] ([ProductID], [ProductName], [Price], [CategoryID], [CompanyID]) VALUES (1, N'Toned milk 500ml', 22, 1, 1)
GO
INSERT [dbo].[StudentCourses] ([ProductID], [ProductName], [Price], [CategoryID], [CompanyID]) VALUES (2, N'Toned milk 1ltr', 42, 1, 1)
GO
INSERT [dbo].[StudentCourses] ([ProductID], [ProductName], [Price], [CategoryID], [CompanyID]) VALUES (3, N'Full Cream Milk 500ml', 26, 1, 2)
GO
INSERT [dbo].[StudentCourses] ([ProductID], [ProductName], [Price], [CategoryID], [CompanyID]) VALUES (4, N'Butter 100mg', 46, 2, 1)
GO
SET IDENTITY_INSERT [dbo].[StudentCourses] OFF
GO
SET IDENTITY_INSERT [dbo].[Branches] ON 
GO
INSERT [dbo].[Branches] ([OrderID], [ProductID], [Quantity], [CustomerName], [ContactNo], [OrderDate]) VALUES (1, 1, 2, N'Amrit ', N'8596369856', CAST(N'2020-10-16T00:21:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Branches] OFF
GO