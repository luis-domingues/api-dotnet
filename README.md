## API Dotnet CRUD

![GitHub repo size](https://img.shields.io/github/repo-size/luis-domingues/api-dotnet?style=for-the-badge)
![GitHub language count](https://img.shields.io/github/languages/count/luis-domingues/api-dotnet?style=for-the-badge)
![GitHub forks](https://img.shields.io/github/forks/luis-domingues/api-dotnet?style=for-the-badge)

> This project is under development

This is a simple API project using **Dotnet with CSharp, Entity Framework Core, and Angular**. The API allows creating, reading, and updating records of people in a list. It uses REST verbs, and you can test it with Swagger and Postman or make requests directly in the browser.

## Technologies Used

- [.NET with SDK](https://dotnet.microsoft.com/download)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/)

## Project Setup

1. Clone the repository:
```bash
git clone https://github.com/luis-domingues/api-dotnet
cd ApiCrud
```

2. Install Entity Framework Core tools - .NET Core CLI:
```bash
dotnet tool install --global dotnet-ef
````

3. Restore the NuGet packages:
```bash
dotnet restore
```

4. Start the application.

<h3>Attention</h3>

Debug the project in your IDE to access the localhost link.

<h3>Optional</h3>

You can run the project using [Postman](https://www.postman.com/downloads/)

## Project Structure
`Routes`: Contains the `RoutesPessoas` class that defines the API routes.

`Models`: Contains the `Pessoa.cs` class that simulates a database.

## Contributions

Contributions are welcome! Feel free to open an Issue or a Pull Request.