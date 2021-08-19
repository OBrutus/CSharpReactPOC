import { ResponseChk, ErrorChk } from "./chkApi";
let url = process.env.REACT_APP_API_URL + "/movies/";

export function getMovies() {
  return fetch(url).then(ResponseChk).catch(ErrorChk);
}
