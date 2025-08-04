import React, { useState } from 'react';

function CurrencyConvertor() {
  const [rupees, setRupees] = useState('');
  const [euro, setEuro] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    const euroValue = (parseFloat(rupees) / 90).toFixed(2);
    setEuro(euroValue);
  };

  return (
    <div>
      <h2>Currency Convertor (₹ → €)</h2>
      <form onSubmit={handleSubmit}>
        <input
          type="number"
          placeholder="Enter Rupees"
          value={rupees}
          onChange={(e) => setRupees(e.target.value)}
          required
        />
        <button type="submit">Convert</button>
      </form>
      {euro && <p>Euro: €{euro}</p>}
    </div>
  );
}

export default CurrencyConvertor;
