# Các công nghệ sử dụng
	- ASP.NET Core MVC
	- Entity Framework
	- Bootstrap
	- SQL
	- Ajax để call Api

# Các bước chạy:

1. Vào file "appsettings.json", chỉnh sửa chỗi "ConnectionString" cho trỏ tới SQL server của máy tính

2. Thực hiện khởi tạo CSDL và Seeding data bằng lệnh (1 in 2):
	+ Package Manager Console: update-database
	+ Terminal/PowerShell: dotnet ef database update

3. Thực hiện chạy web
	+ Visual Studio xxxx: nhấn nút run mặc định
	+ Terminal/PowerShell: dotnet watch run / dotnet run