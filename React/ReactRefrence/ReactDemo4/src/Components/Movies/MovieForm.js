import React from "react";
import PropTypes from "prop-types";

function MovieForm(props) {
  let containerClass = "form-group";
  if (props.errors.length > 0) {
    containerClass += "has-error";
  }
  return (
    <form onSubmit={props.onSubmit}>
      <div className={containerClass}>
        <label>Movie Title</label>
        <div className="field">
          <input
            id="title"
            type="text"
            name="title"
            className="form-control"
            onChange={props.onChange}
            value={props.movie.title}
          />
          {props.errors.title && (
            <div className="alert alert-danger">{props.errors.title}</div>
          )}
        </div>
      </div>

      <div className={containerClass}>
        <label>Actor</label>``
        <div className="field">
          <select
            id="actor"
            name="actorId"
            onChange={props.onChange}
            className="form-control"
            value={props.movie.actorId || ""}
          >
            <option value="" />
            <option value="1">Robert Downey</option>
            <option value="2">Scar Jo</option>
          </select>
        </div>
        {props.errors.actorId && (
          <div className="alert alert-danger">{props.errors.actorId}</div>
        )}
      </div>

      <div className={containerClass}>
        <label>Movie Genre</label>
        <div className="field">
          <input
            id="genre"
            type="text"
            name="genre"
            onChange={props.onChange}
            className="form-control"
            value={props.movie.genre}
          />
        </div>
        {props.errors.genre && (
          <div className="alert alert-danger">{props.errors.genre}</div>
        )}
      </div>

      <button type="submit" className="btn btn-warning" disabled={props.saving}>
        {props.saving ? "Saving.." : "Save"}
      </button>
      <input
        type="button"
        value="Delete Movie"
        className="btn btn-danger"
        onClick={props.onDelete}
      />
    </form>
  );
}

MovieForm.propTypes = {
  movie: PropTypes.object.isRequired,
  onSubmit: PropTypes.func.isRequired,
  onChange: PropTypes.func.isRequired,
  errors: PropTypes.object.isRequired,
};
export default MovieForm;
