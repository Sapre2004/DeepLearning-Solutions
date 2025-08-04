import React from 'react';

const ListofPlayers = () => {
  const players = [
    { name: 'Virat', score: 88 },
    { name: 'Rohit', score: 70 },
    { name: 'Rahul', score: 68 },
    { name: 'Dhawan', score: 75 },
    { name: 'Gill', score: 60 },
    { name: 'Pant', score: 90 },
    { name: 'Jadeja', score: 40 },
    { name: 'Bumrah', score: 80 },
    { name: 'Shami', score: 65 },
    { name: 'Kuldeep', score: 55 },
    { name: 'Chahal', score: 77 }
  ];

  // Map to list players
  const playerList = players.map((p, i) => (
    <li key={i}>{p.name} - {p.score}</li>
  ));

  // Filter players with score < 70 using arrow function
  const lowScorers = players.filter(p => p.score < 70);

  return (
    <div>
      <h2>All Players</h2>
      <ul>{playerList}</ul>

      <h2>Players with Score Below 70</h2>
      <ul>
        {lowScorers.map((p, i) => (
          <li key={i}>{p.name} - {p.score}</li>
        ))}
      </ul>
    </div>
  );
};

export default ListofPlayers;
