# Frontend Coding Challenge (React TypeScript)

This is the frontend portion of the fullstack coding challenge. It's a React TypeScript project that consumes the backend API to display product data.

## Project Structure

- `src/components/` - React components
- `src/services/` - API services for data fetching
- `src/App.tsx` - Main application component

## Getting Started

1. Navigate to the coding-challenge-app directory:
   ```
   cd coding-challenge-app
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

## Challenge Tasks

1. Enhance the product list UI with additional features:
   - Add filtering by category
   - Add sorting by price (low to high, high to low)
   - Add search functionality

2. Implement a product detail view:
   - Create a new component for displaying product details
   - Add routing to navigate between the product list and detail views
   - Fetch product details from the backend API

3. Improve error handling and loading states:
   - Add more informative error messages
   - Implement loading indicators or skeletons

4. (Optional) Implement a simple shopping cart feature:
   - Add "Add to Cart" buttons to products
   - Create a cart component to display selected items
   - Implement basic cart functionality (add, remove, update quantity)

## Tips

- The current implementation already includes basic error handling and loading states
- Focus on improving the user experience
- Consider using React Router for navigation between views
- Think about state management for more complex features like the shopping cart
- Pay attention to responsive design 