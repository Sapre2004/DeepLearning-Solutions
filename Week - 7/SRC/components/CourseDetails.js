import React from 'react';

const courses = [
  { id: 1, name: 'React Basics', duration: '4 weeks' },
  { id: 2, name: 'Advanced React', duration: '6 weeks' }
];

function CourseDetails() {
  return (
    <div>
      <h2>🎓 Course Details</h2>
      <ul>
        {courses.map(course => (
          <li key={course.id}>
            <strong>{course.name}</strong> - {course.duration}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default CourseDetails;
