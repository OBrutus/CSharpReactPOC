import React from "react";
import renderer from "react-test-renderer";
import Contact from "./Contact";

test("Creating a snapshot of Contact Component", () => {
  const component = renderer.create(<Contact />);
  const treesnapshot = component.toJSON();
  expect(treesnapshot).toMatchSnapshot();
});
