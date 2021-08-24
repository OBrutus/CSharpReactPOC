import React, {Component, useState, useEffect} from "react";

// function Test() {
//   const [error, setError] = useState(null);
//   const [isLoaded, setIsLoaded] = useState(false);
//   const [items, setItems] = useState([]);

//   useEffect(() => {
// 	fetch("http://localhost:8000/cars")
// 	  .then(res => res.json())
// 	  .then(
// 		(result) => {
// 			setIsLoaded(true);
// 			setItems(result);
// 		},
// 		(error) => {
// 			setIsLoaded(true);
// 			console.error("Error occurred failed to load", error);
// 			setError(error);
// 		}
// 	  )
//   }, [])

//   if (error) {
// 	return <div>Error: {error.message}</div>;
//   } else if (!isLoaded) {
// 	return <div>Loading...</div>;
//   } else {
// 	return (
// 	  <ul>
// 		{items.map(item => (
// 			<li key={item}>
// 				{item}
// 			</li>
// 		))}
// 	  </ul>
// 	);
//   }
// }

class Test extends Component {
  constructor(props) {
    super(props);
    this.state = {
      items: [],
      isLoaded: false
    };
  }

  componentDidMount() {
    fetch(
      "https://www.googleapis.com/youtube/v3/channels?part=statistics&id=UCOYqNBjmWF8j-PzI7ZPjt_w&key=AIzaSyAMeZQW6sUQgLdDTnMVeokfbcFcT2A9SuA"
    )
      .then(res => res.json())
      .then(({ items }) => {
        this.setState({
          isLoaded: true,
          items
        });
      });
  }

  render() {
    var { isLoaded, items } = this.state;
    if (!isLoaded) return <div>Loading...</div>;
	// console.log('3333333333333333333333333\n', items);
    return (
      <div>
        <ul>
          {items.map(({ id, statistics }) => (
            <li key={id}>
              Total views: {statistics.viewCount}
              Total subscribers: {statistics.subscriberCount}
              Total videos: {statistics.videoCount}
            </li>
          ))}
        </ul>
      </div>
    );
  }
}

export default Test;