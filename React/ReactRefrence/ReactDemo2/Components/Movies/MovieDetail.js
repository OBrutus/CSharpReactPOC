import React from "react";

const MovieDetail = (props) => {
  return (
    <>
      <h2>Movie Info - Add/Edit</h2>
      {props.match.params.slug}
    </>
  );
};
export default MovieDetail;
