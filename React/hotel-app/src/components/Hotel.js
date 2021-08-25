import React from 'react'
import Button from './Button'

export default function Hotel( {hotel, onDelete} ) {
    return (
        <div key = {hotel.id}>
            <hr/>
            <h3>{hotel.id}: {hotel.City}</h3>
            <p>{hotel.description}</p>
            <Button title='Remove Hotel' onClick={() => {console.log(hotel); onDelete(hotel.id)}} />
        </div>
    )
}
