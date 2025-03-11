# Fullstack Coding Challenge

This is a simple fullstack coding challenge designed to assess a candidate's experience with C# and React. The challenge should take approximately 20-30 minutes to complete for a senior developer.

## Project Structure

- `backend/` - C# Web API project
- `frontend/` - React TypeScript project

## Challenge Description

The main focus of this challenge is on the backend implementation. The candidate should work on the backend to create APIs that fetch data from the Fake Store API and return refined data through endpoints. The React frontend will consume these endpoints to display the data.

## Getting Started

### Backend (C# Web API)

1. Navigate to the backend directory:
   ```
   cd backend/CodingChallengeApi
   ```

2. Run the API:
   ```
   dotnet run
   ```

3. The API will be available at `https://localhost:7000` (or a similar port)

4. You can access the Swagger documentation at `https://localhost:7000/swagger`

### Frontend (React TypeScript)

1. Navigate to the frontend directory:
   ```
   cd frontend/coding-challenge-app
   ```

2. Install dependencies:
   ```
   npm install
   ```

3. Run the development server:
   ```
   npm start
   ```

4. The React app will be available at `http://localhost:3000`

## Tasks for the Candidate

### Backend Tasks (Primary Focus)

1. Modify the `ProductService.cs` to fetch real product data from the Fake Store API
2. Implement data transformation to map the API response to our Product model
3. Add proper error handling and logging
4. (Optional) Implement caching to improve performance

### Frontend Tasks (Secondary Focus)

1. Ensure the frontend correctly consumes the backend API
2. Display product images from the API
3. Format the price with proper currency symbol
4. (Optional) Add a simple filter to show products by category

## Evaluation Criteria

- Code quality and organization
- Problem-solving approach
- API design and implementation
- Error handling
- Data transformation and mapping
- Performance considerations 