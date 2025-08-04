// CohortDetails.js
import React from 'react';
import styles from './CohortDetails.module.css'; // ✅ Import CSS Module

function CohortDetails({ name, startDate, endDate, status }) {
  const statusColor = status === 'ongoing' ? 'green' : 'blue'; // ✅ Inline style based on status

  return (
    <div className={styles.box}>
      <h3 style={{ color: statusColor }}>{name}</h3>
      <dl>
        <dt>Start Date:</dt>
        <dd>{startDate}</dd>
        <dt>End Date:</dt>
        <dd>{endDate}</dd>
        <dt>Status:</dt>
        <dd>{status}</dd>
      </dl>
    </div>
  );
}

export default CohortDetails;
