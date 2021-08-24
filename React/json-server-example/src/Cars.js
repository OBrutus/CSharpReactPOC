import React, {useState, useEffect} from "react";

const URL = "127.0.0.1:8000/cars"

function getCars(setIsLoaded, setItems, setError) {
	fetch(URL)
		.then(res => {console.log(res); res.json()})
		.then(
			(result) => {
				setIsLoaded(true);
				setItems(result);
			},
			// Note: it's important to handle errors here
			// instead of a catch() block so that we don't swallow
			// exceptions from actual bugs in components.
			(error) => {
				setIsLoaded(true);
				setError(error);
			}
		);
}

function Cars() {
  const [error, setError] = useState(null);
  const [isLoaded, setIsLoaded] = useState(false);
  const [items, setItems] = useState([]);

  // Note: the empty deps array [] means
  // this useEffect will run once
  // similar to componentDidMount()
  useEffect(() => {
	getCars(setIsLoaded, setItems, setError);
  }, [])

  if (error) {
	return <div>Error: {error.message}</div>;
  } else if (!isLoaded) {
	return <div>Loading...</div>;
  } else {
	return (
	  <ul>
          {items.map(item => (
            <li key={item.id}>
              {item.name} {item.price}
            </li>
          ))}
        </ul>
	);
  }
}


export default Cars;