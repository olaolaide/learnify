Learnify
Overview
Learnify is a comprehensive learning platform developed using ASP.NET and the Repository Pattern. The platform aims to provide a seamless learning experience with a user-friendly interface, allowing users to access and manage educational content efficiently.

Project Structure
The project is divided into two main parts:

Backend: Developed using ASP.NET with the Repository Pattern to ensure a clean and maintainable codebase.
Frontend: Developed using React and Vite, with a modern and responsive UI/UX design.
Getting Started
Prerequisites
Before you begin, ensure you have the following installed:

.NET SDK
Node.js and npm
Installation
Clone the repository:

bash
Copy code
git clone https://github.com/yourusername/learnify.git
cd learnify
Backend Setup:

Navigate to the backend directory:
bash
Copy code
cd backend
Restore the dependencies:
bash
Copy code
dotnet restore
Build the project:
bash
Copy code
dotnet build
Run the project:
bash
Copy code
dotnet run
Frontend Setup:

Navigate to the frontend directory:
bash
Copy code
cd client
Install the dependencies:
bash
Copy code
npm install
Start the development server:
bash
Copy code
npm run dev
Scripts
Development: npm run dev
Build: npm run build
Lint: npm run lint
Preview: npm run preview
Dependencies
Backend
ASP.NET Core
Entity Framework Core
Frontend
Dependencies:
antd: ^5.18.3
axios: ^1.7.2
react: ^18.3.1
react-dom: ^18.3.1
react-icons: ^5.2.1
react-router-dom: ^6.23.1
DevDependencies:
@types/react: ^18.3.3
@types/react-dom: ^18.3.0
@typescript-eslint/eslint-plugin: ^7.13.1
@typescript-eslint/parser: ^7.13.1
@vitejs/plugin-react: ^4.3.1
eslint: ^8.57.0
eslint-plugin-react-hooks: ^4.6.2
eslint-plugin-react-refresh: ^0.4.7
sass: ^1.77.6
typescript: ^5.2.2
vite: ^5.3.1
Repository Pattern
The Repository Pattern is used to create a separation between the data access and business logic layers of the application. This ensures a clean architecture, making the codebase more maintainable and testable.

Example
Here is a basic example of the Repository Pattern implementation in this project:

Interface
csharp
Copy code
public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(int id);
    Task Add(T entity);
    Task Update(T entity);
    Task Delete(int id);
}
Implementation
csharp
Copy code
public class Repository<T> : IRepository<T> where T : class
{
    private readonly DbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(DbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T> GetById(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task Add(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
Contributing
We welcome contributions from the community. If you would like to contribute, please follow these steps:

Fork the repository.
Create a new branch.
Make your changes and commit them.
Push your branch and create a pull request.
License
This project is licensed under the MIT License. See the LICENSE file for more details.
