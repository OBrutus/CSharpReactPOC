import React, { Component } from "react";

class About extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      counter: 0,
    };
    console.log("Construcor phase");
  }

  updatecounter() {
    this.setState((prevState, props) => {
      return { counter: prevState.counter + 1 };
    });
  }

  render() {
    return (
      <div className="jumbotron">
        <h2>Find out about the movie subscriptions here!</h2>
        <button
          style={{ marginBottom: "10px", marginTop: "5px" }}
          className="btn btn-warning"
          onClick={() => this.updatecounter()}
        >
          {" "}
          Hit Counter {this.state.counter}
        </button>
        <div id="chkstatus"></div>
        <div id="chkcurrent"></div>
      </div>
    );
  }

  componentDidMount() {
    console.log("Component mounted on DOM");
  }

  getSnapshotBeforeUpdate(prevProps, prevState) {
    document.getElementById("chkstatus").innerHTML =
      "Before the update, the counter was " + prevState.counter;
  }

  componentDidUpdate() {
    console.log("Component Updating");
    document.getElementById("chkcurrent").innerHTML =
      "Before the update, the counter was " + this.state.counter;
  }

  componentWillUnmount() {
    console.log("Comp unmounting..");
  }
}

About.defaultProps = {
  name: "EMovies",
  tag: "Keep Watching..",
};

export default About;
