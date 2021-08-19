import React from "react";

class Movies extends React.Component {
  state = {
    moviedata: [
      { id: 1, title: "Inception", star: "Leonorda", genre: "sci-fi" },
      { id: 2, title: "Castaway", star: "Tom", genre: "Drama" },
      { id: 3, title: "Avatar", star: "Leon", genre: "sci-fi" },
      { id: 4, title: "FightClub", star: "Brad", genre: "Action" },
    ],
  };

  render() {
    return (
      <>
        <h2>Welcome to EMovies!</h2>
        <h4>Check out the blockbusters here..</h4>
        <table className="table">
          <thead>
            <tr>
              <th>Title</th>
              <td>Star</td>
              <td>Genre</td>
            </tr>
          </thead>
          <tbody>
            {this.state.moviedata.map((movie) => {
              return (
                <tr>
                  <td>{movie.title}</td>
                  <td>{movie.star}</td>
                  <td>{movie.genre}</td>
                </tr>
              );
            })}
          </tbody>
        </table>
      </>
    );
  }
}
export default Movies;
