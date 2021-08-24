import { Route, Switch, Redirect } from "react-router-dom";
import Nav from "./Common/Nav";
import NavFooter from "./Common/NavFooter";
import Home from "./Home/Home";
import Contact from "./Contact/Contact";
import About from "./About/About";
import PgNotFound from "./PgNotFound/PgNotFound";
import Movies from "./Movies/Movies";
import MovieDetail from "./Movies/MovieDetail";
import FormDemo from "./FormDemo";
import FormDemoUnctrl from "./FormDemoUnctrl";
import RBDemo from "./RBDemo";
import { Toaster } from "react-hot-toast";

function App(props) {
  return (
    <div className="container-fluid">
      <Nav />
      <Switch>
        <Route path="/" exact component={Home} />
        <Route path="/movies" component={Movies} />
        <Route path="/movie/:slug" component={MovieDetail} />
        <Route path="/movie" component={MovieDetail} />
        <Route path="/contact" component={Contact} />
        <Route path="/about" component={About} />
        <Redirect from="/olpg" to="contact" />
        <Route component={PgNotFound} />
      </Switch>
      <Toaster
        position="top-right"
        gutter={24}
        toastOptions={{
          duration: 4000,
          style: {
            background: "#353537",
            color: "#fff",
          },
          success: {
            duration: 3000,
            theme: {
              primary: "green",
              secondary: "darkslategrey",
            },
          },
        }}
      />
    </div>
  );
}

export default App;
