// src/Posts.js
import React, { Component } from 'react';
import Post from './Post';

class Posts extends Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      error: false
    };
  }

  // Method to fetch posts
  loadPosts = () => {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then((res) => res.json())
      .then((data) => {
        const postList = data.map(item => new Post(item.id, item.title, item.body));
        this.setState({ posts: postList });
      })
      .catch(error => {
        console.error("Fetch error:", error);
        this.setState({ error: true });
      });
  };

  // Lifecycle hook
  componentDidMount() {
    this.loadPosts();
  }

  // Error boundary method
  componentDidCatch(error, info) {
    alert("An error occurred while rendering the component.");
    console.error("Caught error:", error, info);
  }

  render() {
    const { posts, error } = this.state;

    if (error) {
      return <h3>Unable to load posts. Please try again later.</h3>;
    }

    return (
      <div>
        <h1>Blog Posts</h1>
        {posts.map((post) => (
          <div key={post.id} style={{ border: '1px solid #ccc', padding: '10px', marginBottom: '10px' }}>
            <h2>{post.title}</h2>
            <p>{post.body}</p>
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;
