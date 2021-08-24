import Header from "./components/Header";
import Button from "./components/Button";
import AllHotels from "./components/AllHotels";

function App() {
  return (
    <>
      <Header title='Ocean View'/>
      <Button title='Book Room' />
      <AllHotels />
    </>
  );
}

export default App;
