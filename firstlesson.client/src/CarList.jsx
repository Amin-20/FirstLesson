import { useEffect, useState } from "react";

export default function CarList() {

    const [cars, setCars] = useState([]);

    useEffect(() => {
        GetCarList();
    }, []);

    async function GetCarList() {
        try {
            const response = await fetch("/car");
            console.log(response);
            const data = await response.json();
            setCars(data);
        } catch (error) {
            console.log('Error fetching car list:', error);
        }
    }

    return (
        <div style={{ display: "flex" }}>
            {cars.map((c, index) => (
                <div key={index} style={{ width: "200px", border: "2px solid springgreen" }}>
                    <h1>Brand: {c.brand}</h1>
                    <h1>Model: {c.model}</h1>
                    <h1>Year: {c.year}</h1>
                    <h1>Engine: {c.engine}</h1>
                    <h1>Color: {c.color}</h1>
                    <h1>Distance: {c.distance}</h1>
                </div>
            ))}
        </div>
    );
}
