import React from "react";
import { NavLink, Link } from "react-router-dom";

const navstyle = {
  backgroundColor: "wheat",
};

const mystyle = {
  color: "darkslateblue",
};


const NavFooter = () =>{
  return (
    <>
      <nav className="navbar navbar-expand-lg navbar-light" style={navstyle}>
        <button
          className="navbar-toggler"
          type="button"
          data-toggle="collapse"
          data-target="#navbarNav"
        >
          <span className="navbar-toggler-icon"></span>
        </button>
        <div className="collapse navbar-collapse" id="navbarNav">
          <ul className="navbar-nav">
            <li className="nav-item">
              <NavLink
                className="nav-link"
                to="/"
                activeStyle={{ color: "darkslateblue" }}
              >
                Home
              </NavLink>
            </li>
            <li className="nav-item">
              <NavLink className="nav-link" to="/movies">
                Movies
              </NavLink>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/contact">
                Contact
              </Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/about">
                About Us
              </Link>
            </li>
          </ul>
        </div>
      </nav>

    </>
  );
}

export default NavFooter;
