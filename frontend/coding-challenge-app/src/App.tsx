import React from 'react';
import './App.css';
import ProductList from './components/ProductList';
import './components/ProductList.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1>Product Catalog</h1>
        <p>A simple product catalog application</p>
      </header>
      <main>
        <ProductList />
      </main>
      <footer className="App-footer">
        <p>Coding Challenge - Fullstack Application</p>
      </footer>
    </div>
  );
}

export default App;
