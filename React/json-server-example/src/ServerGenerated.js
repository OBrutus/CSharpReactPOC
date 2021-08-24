// index.js
module.exports = () => {
	const data = { users: [], cars: [] }
	for (let i = 0; i < 1000; i++) {
		data.users.push({ id: i, name: `user${i}` });
		data.cars.push({ id: i, name: 'Name' + i, brand: `brand ${i}` });
		data.cars.push({ 
			"items": [
				{ "id": 1, "name": "Apples",  "price": "$2" },
				{ "id": 2, "name": "Peaches", "price": "$5" }
			]
		})
	}
	return data
}
