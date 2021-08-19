import './App.css';
import { useState, useEffect } from 'react';

function App() {
  // useState
  const [movies, setMovies] = useState([]);

  useEffect( () => 
    fetch("https://api.github.com/users/obrutus")
      .then(resp => console.log(resp))
    )

  return (
    <>
      hello
    </>
  );
}

export default App;
