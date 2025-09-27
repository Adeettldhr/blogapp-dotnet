# blogapp-dotnet
A web based project using .net framework


1. Restore dependencies

Since bin/ and obj/ are ignored, you’ll need to rebuild the project:

dotnet restore


This downloads all NuGet packages defined in your .csproj.

🔹 2. Apply database migrations

Because your SQLite .db file is ignored, each developer needs to generate their own local database.

Run:

dotnet ef database update


This will create a fresh blog.db from the migrations in your Migrations/ folder.

(If you don’t have the EF CLI installed, install it once with:)

dotnet tool install --global dotnet-ef

🔹 3. Configure secrets/environment variables

Since appsettings.Development.json is ignored (for security), each dev should create their own local copy if needed.
For sensitive values (like connection strings, API keys), you can use the .NET Secret Manager:

dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "YourConnectionStringHere"

🔹 4. Build and run the project

Finally:

dotnet build
dotnet run


And your app should be running 🎉