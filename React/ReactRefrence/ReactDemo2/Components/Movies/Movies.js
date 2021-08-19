import React, { useEffect, useState } from "react";
import { getMovies } from "../../apicalls/movieApi";
import  MovieList from "./MovieList";

function Movies() {
  // useState
  const [movies, setMovies] = useState([]);

  useEffect(() => {
    getMovies().then((_movies) => setMovies(_movies));
  }, []);

  return (
    <>
      <h2>Welcome to EMovies!</h2>
      <h4>Check out the blockbusters here..</h4>
      <MovieList movies={movies}/>
    </>
  );
}

export default Movies;
