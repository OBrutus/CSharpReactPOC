//Json-server - github

const jsonServer = require("json-server");
const server = jsonServer.create();
const path = require("path");
const router = jsonServer.router(path.join(__dirname, "db.json"));
const middlewares = jsonServer.defaults({
  static: "node_modules/json-server/dist",
});

// Set default middlewares (logger, static, cors and no-cache)
server.use(middlewares);
// To handle POST, PUT and PATCH you need to use a body-parser
// You can use the one used by JSON Server
server.use(jsonServer.bodyParser);
server.use(function (req, res, next) {
  setTimeout(next, 0);
});

server.use((req, res, next) => {
  if (req.method === "POST") {
    req.body.createdAt = Date.now();
  }
  // Continue to JSON Server router
  next();
});

//server - movie post request
server.post("/movies/", function (req, res, next) {
  let error = checkmovie(req.body);
  if (error) {
    res.status(400).send(error);
  } else {
    req.body.slug = generateurlSlug(req.body.title); //Genereate the slug for new MOvies
    next();
  }
});

function generateurlSlug() {
  return value
    .replace(/[^a-z0-9_]+/gi, "-")
    .replace(/^-|-$/g, "")
    .toLowerCase();
}

function checkmovie(movie) {
  if (!movie.title) return "Please enter title";
  return "";
}

// Use default router
server.use(router);
server.listen(3001, () => {
  console.log("JSON Server is running at port 3001..");
});
