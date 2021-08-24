import React, { useEffect, useState } from "react";
import MovieForm from "./MovieForm";
import toast from "react-hot-toast";
import * as movieApi from "../../apicalls/movieApi";

const MovieDetail = (props) => {
  const [errors, setErrors] = useState({});
  const [movie, setMovie] = useState({
    id: null,
    title: "",
    actorId: null,
    genre: "",
  });
  const [saving, setSave] = useState(false);

  useEffect(() => {
    const slug = props.match.params.slug; //"/movies/:slug"
    if (slug) {
      movieApi.getMoviebySlug(slug).then((_movie) => setMovie(_movie));
    }
  }, []);

  function ValidForm(params) {
    const _errors = {};
    if (!movie.title) _errors.title = "Please enter the movie title";
    if (!movie.actorId) _errors.actorId = "Please select the actor ";
    if (!movie.genre) _errors.genre = "Please enter the genre";
    setErrors(_errors);
    return Object.keys(_errors).length === 0;
  }

  //spread operator ...
  function handleChange({ target }) {
    setMovie({
      ...movie,
      [target.name]: target.value,
    });
  }

  function handleSubmit(evt) {
    evt.preventDefault();
    if (!ValidForm()) return;
    setSave(true);
    movieApi.saveMovie(movie).then(() => {
      toast.success("Movie created successfully");
      props.history.push("/movies");
    });
  }

  function handleDelete(evt) {
    evt.preventDefault();
    movieApi.deleteMovie(movie.id).then(() => {
      props.history.push("/movies");
      alert("Movie deleted..");
    });
  }

  return (
    <>
      <h2>Movie Info</h2>
      <MovieForm
        errors={errors}
        movie={movie}
        saving={saving}
        onChange={handleChange}
        onSubmit={handleSubmit}
        onDelete={handleDelete}
      />
    </>
  );
};
export default MovieDetail;
