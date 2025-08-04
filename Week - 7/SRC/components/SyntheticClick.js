import React from 'react';

function SyntheticClick() {
  const handleClick = (event) => {
    alert("I was clicked");
    console.log("Synthetic Event:", event);
  };

  return (
    <div>
      <button onClick={handleClick}>Click Me</button>
    </div>
  );
}

export default SyntheticClick;
