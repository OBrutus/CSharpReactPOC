import movies from "../movies.json";

const size = movies.length;
//Numbers
describe("Number Tests", () => {
  test("Number test of length", () => {
    expect(2+2).toBe(4);
  });
  test("Length of movies should be greater than or equal to 5", () => {
    expect(size).toBeGreaterThanOrEqual(5);
  });
});

//String

const movie = movies[0].title;
describe("String Tests", () => {
  test("The title matches Incep", () => {
    expect(movie).toMatch(/Incep/);
  });

  test("The title contains Leo", () => {
    expect(movie).toContain("Leo");
  });
});

//Arrays/Objects
describe("Array Tests", () => {
  const data = ["React Web", "React Mobile -Native"];
  test("The Data contains contains React & Mobile", () => {
    expect(["React Web", "React Mobile -Native", "Angular"]).toEqual(
      expect.arrayContaining(data)
    );
  });

  test("The first movie has a property title", () => {
    expect(movies[0]).toHaveProperty("title");
  });

  test("The first movie has a property title", () => {
    expect(movies[0]).toHaveProperty("title", "Inception by Leo");
  });
});
