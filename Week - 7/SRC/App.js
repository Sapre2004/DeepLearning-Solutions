import React, { useState } from 'react';
import './App.css';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';

function App() {
  const [view, setView] = useState('none');
  const [showCourses, setShowCourses] = useState(true); // for && rendering

  let element;

  // Element variable example
  if (view === 'books') {
    element = <BookDetails />;
  } else if (view === 'blogs') {
    element = <BlogDetails />;
  }

  return (
    <div className="App" style={{ padding: '20px' }}>
      <h1>📘 Blogger App</h1>

      {/* Buttons for switching views */}
      <button onClick={() => setView('books')}>Show Books</button>
      <button onClick={() => setView('blogs')}>Show Blogs</button>
      <button onClick={() => setView('none')}>Clear View</button>
      <button onClick={() => setShowCourses(!showCourses)}>
        {showCourses ? 'Hide Courses' : 'Show Courses'}
      </button>

      <hr />

      {/* Conditional rendering via element variable */}
      {element}

      {/* Ternary operator rendering */}
      {view === 'none' ? <p>No content selected.</p> : null}

      {/* && operator rendering */}
      {showCourses && <CourseDetails />}
    </div>
  );
}

export default App;
