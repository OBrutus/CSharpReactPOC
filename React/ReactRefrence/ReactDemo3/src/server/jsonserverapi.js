const jsonServer = require("json-server");
const server = jsonServer.create();
const path = require("path");
const router = jsonServer.router(path.join(__dirname, "db.json"));

const middlewares = jsonServer.defaults({
  static: "node_modules/json-server/dist",
});

server.use(middlewares);

server.use(jsonServer.bodyParser);

server.use(function (req, res, next) {
  setTimeout(next, 3000);
});

server.use((req, res, next) => {
  if (req.method === "POST") {
    req.body.createdAt = Date.now();
  }
  next();
});

server.post("/movies/", function (req, res, next) {
  const error = checkMovie(req.body);
  if (error) {
    res.status(400).send(error);
  } else {
    req.body.slug = generateurlSlug(req.body.title);
    next();
  }
});

server.use(router);

server.listen(3001, () => {
  console.log(`JSON Server is running at port 3001`);
});

function generateurlSlug(value) {
  return value
    .replace(/[^a-z0-9_]+/gi, "-")
    .replace(/^-|-$/g, "")
    .toLowerCase();
}

function checkMovie(movie) {
  if (!movie.title) return " Movie Title is required.";
  if (!movie.actorId) return "Actor is required.";
  if (!movie.genre) return "Genre is required.";
  return "";
}
