//to recreate the fake db - db.json for every server restart

const fs = require("fs");
const path = require("path");
const fakedb = require("./fakedata");
const { movies, actors } = fakedb;
const data = JSON.stringify({ movies, actors });
const fpath = path.join(__dirname, "db.json");

fs.writeFile(fpath, data, function (err) {
  err ? console.log(err) : console.log("Db Sample created..");
});
