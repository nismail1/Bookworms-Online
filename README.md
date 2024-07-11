# Bookworms Online

Bookworms Online is a comprehensive web application designed for book enthusiasts to explore, review, and purchase a wide range of books. This project leverages C# and ASP.NET MVC framework for the backend and incorporates a responsive and user-friendly front-end interface.

## Features

- **User Authentication**: Secure user registration and login functionality.
- **Book Browsing**: Extensive catalog of books with detailed information.
- **Search and Filter**: Advanced search and filtering options to find books by title, author, genre, and more.
- **Reviews and Ratings**: Users can leave reviews and ratings for books.
- **Shopping Cart**: Add books to the cart and proceed to checkout.
- **Order Management**: Track orders and view order history.

## Technologies Used

- **Backend**: C#, ASP.NET MVC
- **Frontend**: HTML, CSS, JavaScript
- **Database**: SQL Server
- **Other Tools**: Entity Framework, LINQ, Bootstrap

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/nismail1/Bookworms-Online.git
    ```
2. Navigate to the project directory:
    ```bash
    cd Bookworms-Online
    ```
3. Restore the dependencies:
    ```bash
    dotnet restore
    ```
4. Update the database connection string in `appsettings.json`:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Your SQL Server connection string here"
    }
    ```
5. Apply migrations to set up the database:
    ```bash
    dotnet ef database update
    ```
6. Run the application:
    ```bash
    dotnet run
    ```

### Running the Tests

To run the tests, use the following command:
```bash
dotnet test
