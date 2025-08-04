import React from 'react';

function FlightDetails() {
  const flights = [
    { flightNo: 'AI202', destination: 'Delhi', time: '10:00 AM' },
    { flightNo: '6E512', destination: 'Mumbai', time: '1:30 PM' },
    { flightNo: 'SG101', destination: 'Kolkata', time: '6:45 PM' }
  ];

  return (
    <div>
      <h2>Available Flights</h2>
      <ul>
        {flights.map((flight, index) => (
          <li key={index}>
            ✈️ Flight {flight.flightNo} to {flight.destination} at {flight.time}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default FlightDetails;
