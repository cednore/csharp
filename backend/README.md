# Backend Coding Challenge (C# Web API)

This is the backend portion of the fullstack coding challenge. It's a C# Web API project that provides endpoints for product data.

## Project Structure

- `Controllers/` - API controllers
- `Models/` - Data models
- `Services/` - Business logic and external API integration

## Getting Started

1. Navigate to the CodingChallengeApi directory:
   ```
   cd CodingChallengeApi
   ```

2. Run the API:
   ```
   dotnet run
   ```

3. The API will be available at `https://localhost:7000` (or a similar port)

4. You can access the Swagger documentation at `https://localhost:7000/swagger`

## API Endpoints

- `GET /api/products` - Get all products
- `GET /api/products/{id}` - Get a specific product by ID

## Challenge Tasks

1. Modify the `ProductService.cs` to fetch real product data from an external API instead of using mock data
   - Suggested API: [Fake Store API](https://fakestoreapi.com/products)
   - Alternative: [Dummy JSON](https://dummyjson.com/products)

2. Implement data transformation to map the external API response to our Product model

3. Add proper error handling and logging

4. (Optional) Implement caching to improve performance

5. (Optional) Add additional endpoints for filtering products by category or searching by name

## Tips

- The current implementation uses mock data in `ProductService.cs`
- You'll need to replace this with actual HTTP calls to an external API
- Consider using HttpClient that's already injected into the service
- Make sure to handle API errors gracefully
- Think about how to optimize the API for performance 