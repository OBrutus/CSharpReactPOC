import React, { useEffect, useState } from "react";
import { getMovies } from "../../apicalls/movieApi";
import MovieList from "./MovieList";
import { Link } from "react-router-dom";

function Movies() {
  // useState
  const [movies, setMovies] = useState([]);

  useEffect(() => {
    getMovies().then((_movies) => setMovies(_movies));
  }, []);

  return (
    <>
      <h4>Check out the blockbusters here..</h4>
      <Link className="btn btn-warning" to="/movie">
        Create Movie
      </Link>
      <MovieList movies={movies} />
    </>
  );
}

export default Movies;
