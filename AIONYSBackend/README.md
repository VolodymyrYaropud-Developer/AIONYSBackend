
This is a RESTful Web API built with **ASP.NET Core 6.0** for managing personal notes. It uses an **In-Memory Database** for storage, making it lightweight and easy to run without external dependencies like SQL Server.
.NET 6.0 SDK
Entity Framework Core (In-Memory)

[.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0).


1.  Navigate to the project folder:
    Open your terminal in the root of the backend project.
    ```
    bash
    cd AIONYSBackend
    ```

2.  Restore dependencies:
    ```
    bash
    dotnet restore
    ```

3.  Run the application:
    ```
    bash
    dotnet run
    ```

4.  Access the API:
    The service usually starts on `https://localhost:7015` (or `http://localhost:5000` depending on your settings).
    Check the console output for the exact URL: `Now listening on: ...`

5.  View Swagger Documentation:
    You can test all endpoints interactively by visiting:
    ```
    https://localhost:7015/swagger/index.html
    ```

API Endpoints

| Method | Endpoint      | Description                                      | Request Body (JSON)               |
| :----- | :------------ | :----------------------------------------------- | :-------------------------------- |
| GET    | `/Notes`      | Get all notes.                                   | N/A                               |
| GET    | `/Notes/{id}` | Get a specific note by ID.                       | N/A                               |
| POST   | `/Notes`      | Create a new note.                               | `{ "title": "...", "content": "..." }` |
| PUT    | `/Notes/{id}` | Update an existing note.                         | `{ "title": "...", "content": "..." }` |
| DELETE | `/Notes/{id}` | Delete a note by ID.                             | N/A                               |


CORS
The API is configured to allow Cross-Origin Resource Sharing (CORS) from any origin (`AllowAll`), which allows the React frontend to communicate with it without restriction during development.

Database
The project uses `Microsoft.EntityFrameworkCore.InMemory`. Data is stored in RAM and will be reset every time the application restarts.