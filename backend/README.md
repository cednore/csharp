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

1. Modify the `ProductService.cs` to fetch real product data from the Fake Store API:
   - API Endpoint: `https://fakestoreapi.com/products`
   - Sample response structure:
   ```json
   {
     "id": 1,
     "title": "Fjallraven - Foldsack No. 1 Backpack",
     "price": 109.95,
     "description": "Your perfect pack for everyday use...",
     "category": "men's clothing",
     "image": "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg",
     "rating": {
       "rate": 3.9,
       "count": 120
     }
   }
   ```

2. Implement data transformation to map the Fake Store API response to our Product model:
   - Map `title` to `Name`
   - Map `description` to `Description`
   - Map `price` to `Price`
   - You can set a default value for `StockQuantity` or use `rating.count`
   - Map `category` to `Category`

3. Add proper error handling and logging:
   - Handle HTTP request failures
   - Log errors with appropriate context
   - Return meaningful error responses to the client

4. (Optional) Implement caching to improve performance:
   - The service already has a basic caching mechanism
   - Improve it with a more sophisticated approach (e.g., memory cache with expiration)

5. (Optional) Add additional endpoints:
   - Filtering products by category
   - Searching products by name

## Tips

- Use the HttpClient that's already injected into the ProductService
- Consider using System.Text.Json for deserializing the API response
- Make sure to handle API errors gracefully
- Think about how to optimize the API for performance 