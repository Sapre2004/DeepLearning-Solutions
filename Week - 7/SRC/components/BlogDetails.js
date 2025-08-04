import React from 'react';

const blogs = [
  { id: 101, title: 'Understanding JSX', author: 'Jane' },
  { id: 102, title: 'React Hooks Overview', author: 'John' }
];

function BlogDetails() {
  return (
    <div>
      <h2>📝 Blog Details</h2>
      <ul>
        {blogs.map(blog => (
          <li key={blog.id}>
            <strong>{blog.title}</strong> by {blog.author}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default BlogDetails;
