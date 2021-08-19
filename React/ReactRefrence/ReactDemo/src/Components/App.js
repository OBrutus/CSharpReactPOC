import { Route, Switch, Redirect } from "react-router-dom";
import Nav from "./Common/Nav";
import Home from "./Home/Home";
import Contact from "./Contact/Contact";
import About from "./About/About";
import PgNotFound from "./PgNotFound/PgNotFound";
import Movies from "./Movies/Movies";

function App(props) {
  return (
    <div className="container-fluid">
      <Nav />
      <Switch>
        <Route path="/" exact component={Home} />
        <Route path="/movies" component={Movies} />
        <Route path="/contact" component={Contact} />
        <Route path="/about" component={About} />
        <Redirect from="/olpg" to="contact" />
        <Route component={PgNotFound} />
      </Switch>
    </div>
  );
}

export default App;
