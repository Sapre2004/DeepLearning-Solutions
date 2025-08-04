import React from 'react';

const IndianPlayers = () => {
  const T20 = ['Kohli', 'Rohit', 'Pant', 'Hardik'];
  const Ranji = ['Pujara', 'Iyer', 'Ashwin', 'Rahane'];

  // Merge arrays using spread operator (ES6)
  const merged = [...T20, ...Ranji];

  // Destructuring
  const [odd1, even1, odd2, even2] = merged;

  return (
    <div>
      <h2>Merged Players</h2>
      <ul>
        {merged.map((p, i) => (
          <li key={i}>{p}</li>
        ))}
      </ul>

      <h2>Destructured Teams</h2>
      <p>Odd Team: {odd1}, {odd2}</p>
      <p>Even Team: {even1}, {even2}</p>
    </div>
  );
};

export default IndianPlayers;
