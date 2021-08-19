import React from "react";
import PropTypes from "prop-types";
import { Link } from "react-router-dom";

function MovieList(props) {
  return (
    <table className="table">
      <thead>
        <tr>
          <th>Title</th>
          <td>Star</td>
          <td>Genre</td>
        </tr>
      </thead>
      <tbody>
        {props.movies.map((movie) => {
          return (
            <tr>
              <Link to={"/movie/" + movie.slug}>{movie.title}</Link>

              <td>{movie.actorId}</td>
              <td>{movie.genre}</td>
            </tr>
          );
        })}
      </tbody>
    </table>
  );
}

MovieList.propTypes = {
  movies: PropTypes.arrayOf(
    PropTypes.shape({
      id: PropTypes.number.isRequired,
      title: PropTypes.string.isRequired,
      actorId: PropTypes.number.isRequired,
      genre: PropTypes.string.isRequired,
    })
  ).isRequired,
};

MovieList.defaultProps = {
  movies: [],
};

export default MovieList;
