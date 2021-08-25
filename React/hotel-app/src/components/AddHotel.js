import React, { useState } from 'react'

export default function AddHotel({onAdd}) {
    const style = { margin: '20px', padding: '15px' }

    const [id, setId] = useState('');
    const [name, setName] = useState('');
    const [rooms, setRooms] = useState('');
    const [description, setDescription] = useState('');

    const onSubmit = (e) => {
        console.log(e);
        e.preventDefault()
        if(!e) {
            alert('please add a hotel name');
            return ;
        }
        console.log(e, id, name, rooms, description);
        let obj = {id, name, rooms, description}
        onAdd(obj);
        console.log('in fn.', obj);
        setId('');
        setName('');
        setRooms('');
        setDescription('');
    }

    return (
        <form onSubmit={onSubmit}>
            <h3>New Hotel Info</h3>
            <div className={style}>
                <input
                    type='Number'
                    placeholder='Enter Id'
                    defaultValue={id}
                    noChange={ (e) => setId(e.target.value) }
                />
            </div>
            <div className={style}>
                <input 
                    type='Text' 
                    placeholder='Enter Hotel Name' 
                    defaultValue={name}
                    noChange={ (e) => setName(e.target.value) }
                />
            </div>
            <div className={style}>
                <input 
                    type='Number' 
                    placeholder='Enter Number of Rooms' 
                    defaultValue={rooms}
                    noChange={ (e) => setRooms(e.target.value) }
                />
            </div>
            <div className={style}>
                <input 
                    type='Text' 
                    placeholder='Enter Hotel Description' 
                    defaultValue={description}
                    noChange={ (e) => setDescription(e.target.value) }
                />
            </div>
            <input type='submit' value='Add Hotel Info.' />
        </form>
    )
}
