import React, {useState, useEffect} from "react";
import Header from "./components/Header";
// import Button from "./components/Button";
import AllHotels from "./components/AllHotels";
import AddHotel from "./components/AddHotel";

function App() {
	const [showAddHotel, setShowAddHotel] = useState(false)
	const [hotels, setHotels] = useState([])
	const fetchHotels = async () => {
		const URL = 'http://localhost:4000/hotels'
		const res = await fetch(URL)
		const data = await res.json();
		console.log('in network : ', data);
		return data;
	}

	useEffect(() => {
		const finaliseHotels = async () => {
			const hotels = await fetchHotels();
			console.log('in setting', hotels);
			if(!hotels)
				return;
			setHotels(hotels);
		}
		finaliseHotels();
	}, [])

	// delete hotels fn. 
	const deleteHotel = (id) => {
		console.log('delete', 'hotel = '+id);
		setHotels(  hotels.filter( (itr) => { console.log(itr); return itr.id !== id} ) );
	}

	const addHotel = (newHotel) => {
		console.log('adding new hotel is ', newHotel);
	}
	
	return (
	<>
		<Header title='Ocean View' 
			buttonShow={!showAddHotel} 
			addHotel={() => setShowAddHotel(!showAddHotel)} />
		{showAddHotel && <AddHotel onAdd={addHotel}/>}
	  	<AllHotels hotels={hotels} onDelete={deleteHotel}/>
	</>
  );
}

export default App;
