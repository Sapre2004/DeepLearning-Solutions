import React from 'react';

function SayWelcome() {
  const welcome = (msg) => {
    alert(msg);
  };

  return (
    <div>
      <button onClick={() => welcome("Welcome to the React Event Lab!")}>
        Say Welcome
      </button>
    </div>
  );
}

export default SayWelcome;
