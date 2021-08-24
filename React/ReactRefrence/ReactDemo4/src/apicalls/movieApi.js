import { movies } from "../server/fakedata";
import { ResponseChk, ErrorChk } from "./chkApi";
let url = process.env.REACT_APP_API_URL + "/movies/";

export function getMovies() {
  return fetch(url).then(ResponseChk).catch(ErrorChk);
}

export function getMoviebySlug(slug) {
  return fetch(url + "?slug=" + slug)
    .then((response) => {
      if (!response.ok)
        throw new Error("Movie by slug cannot be retrieved ..error");
      return response.json().then((movies) => {
        if (movies.length !== 1)
          throw new Error("Cannot find the movie.." + slug);
        return movies[0];
      });
    })
    .catch(ErrorChk);
}

export function saveMovie(movie) {
  return fetch(url + (movie.id || ""), {
    method: movie.id ? "PUT" : "POST",
    headers: { "content-type": "application/json" },
    body: JSON.stringify({
      ...movie,
      actorId: parseInt(movie.actorId, 10),
    }),
  })
    .then(ResponseChk)
    .catch(ErrorChk);
}

export function deleteMovie(movieId) {
  return fetch(url + movieId, {
    method: "DELETE",
  })
    .then(ResponseChk)
    .catch(ErrorChk);
}
