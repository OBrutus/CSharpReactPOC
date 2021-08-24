import React, {useState} from 'react'

export default function AllHotels() {
    const [hotels, setTask] = useState([
        {
            id: '1',
            City: 'Abad',
            description: 'This is common description'
        },
        {
            id: '2',
            City: 'Jaipur',
            description: 'This is common description'
        },
        {
            id: '3',
            City: 'Delhi',
            description: 'This is common description'
        }
    ])

    return (
        <div>
            {hotels.map(
                (hotel) =>  <div key = {hotel.id}>
                        <hr/>
                        <h3>{hotel.id}: {hotel.City}</h3>
                        <p>{hotel.description}</p>
                    </div>
            )}
        </div>
    )
}
