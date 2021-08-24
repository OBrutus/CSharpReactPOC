const movies = [
  {
    id: 1,
    title: "Inception",
    slug: "Incep-leo", //www.localhost.com:3000/movies/Incep-leo
    actorId: 5,
    genre: "Sci-fi",
  },
  {
    id: 2,
    title: "Cast Away",
    slug: "Cast-tom",
    actorId: 4,
    genre: "Drama",
  },
  {
    id: 3,
    title: "Ocean's 13",
    slug: "Oce-brad",
    actorId: 3,
    genre: "Action",
  },
  {
    id: 4,
    title: "Avengers",
    slug: "Ave-Rob",
    actorId: 2,
    genre: "Action",
  },
  {
    id: 5,
    title: "Moana",
    slug: "Moa-Dwa",
    actorId: 1,
    genre: "Animation",
  },
];

const actors = [
  { id: 1, name: "Dwayne Johnson" },
  { id: 2, name: "Robert Downey" },
  { id: 3, name: "Brad Pitt" },
  { id: 4, name: "Tom Hanks" },
  { id: 5, name: "Leonardo Dicaprio" },
];

const newMovie = {
  id: null,
  title: "",
  actorId: null,
  genre: "",
};

module.exports = {
  newMovie,
  movies,
  actors,
};
