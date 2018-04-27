SET IDENTITY_INSERT [dbo].[Guests] ON
INSERT INTO [dbo].[Guests] ([Id], [Name], [Age], [Address], [Contact No.]) VALUES (1, N'Mushfiq', 20, N'Khulna', 1912090415)
SET IDENTITY_INSERT [dbo].[Guests] OFF

Select * From Guests