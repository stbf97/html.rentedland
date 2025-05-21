background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), 
            url('https://png.pngtree.com/thumb_back/fw800/background/20240715/pngtree-leaves-of-banana-abstract-green-dark-texture-nature-background-tropical-leaf-image_16003764.jpg') center/cover no-repeat;
body {
  margin: 0;
  font-family: 'Open Sans', sans-serif;
  background: linear-gradient(135deg, #fff8f0 0%, #ffe8d9 50%, #f5e0d0 100%);
  background-attachment: fixed;
  color: var(--text);
  line-height: 1.6;
  overflow-x: hidden;
}
.cta {
  background: linear-gradient(135deg, var(--secondary), #b28d58);
  color: var(--light);
  text-align: center;
  padding: 3rem 1.5rem;
  border-radius: var(--border-radius);
  box-shadow: var(--shadow);
}

body {
  margin: 0;
  font-family: 'Open Sans', sans-serif;
  background: linear-gradient(120deg, #f6d365 0%, #fda085 50%, #fbc2eb 100%);
  color: var(--text);
  line-height: 1.6;
  overflow-x: hidden;
}

/* Map Image Container */
.map-image-container {
  width: 100%;
  max-width: 800px;
  margin: 0 auto;
  border-radius: var(--border-radius);
  overflow: hidden;
  box-shadow: var(--shadow);
  border: 1px solid rgba(0,0,0,0.1);
}

.map-image {
  width: 100%;
  height: auto;
  display: block;
  transition: var(--transition);
}

.map-image:hover {
  transform: scale(1.02);
}

    /* Full Tour Section */
    .full-tour-container {
      display: flex;
      gap: 2rem;
      margin: 3rem 0;
      background: var(--light);
      border-radius: var(--border-radius);
      box-shadow: var(--shadow);
      overflow: hidden;
    }
    
    .tour-description {
      flex: 1;
      padding: 2rem;
      display: flex;
      flex-direction: column;
      justify-content: center;
    }
    
    .tour-description h3 {
      font-family: 'Playfair Display', serif;
      font-size: 1.8rem;
      color: var(--primary);
      margin-bottom: 1rem;
    }
    
    .tour-description p {
      color: #555;
      margin-bottom: 1.5rem;
      line-height: 1.6;
    }
    
    .tour-features {
      display: flex;
      gap: 1rem;
      flex-wrap: wrap;
      margin-top: 1rem;
    }
    
    .tour-feature {
      display: flex;
      align-items: center;
      gap: 0.5rem;
      background: rgba(201, 168, 107, 0.1);
      padding: 0.5rem 1rem;
      border-radius: 50px;
      font-size: 0.9rem;
      color: var(--primary);
    }
    
    .tour-feature i {
      color: var(--secondary);
    }
    
    .tour-video {
      flex: 1.5;
      position: relative;
    }
    
    .tour-video .video-container {
      width: 100%;
      height: 100%;
      margin: 0;
      max-width: 100%;
    }
    
    .tour-video video {
      width: 100%;
      height: 100%;
      min-height: 400px;
      object-fit: cover;
    }
    
    .video-controls {
      position: absolute;
      bottom: 0;
      left: 0;
      right: 0;
      background: linear-gradient(to top, rgba(0,0,0,0.7), transparent);
      padding: 1rem;
      display: flex;
      align-items: center;
      gap: 1rem;
      opacity: 0;
      transition: var(--transition);
    }
    
    .tour-video:hover .video-controls {
      opacity: 1;
    }
    
    .play-pause-btn, .fullscreen-btn {
      background: none;
      border: none;
      color: white;
      font-size: 1.2rem;
      cursor: pointer;
      width: 30px;
      height: 30px;
      display: flex;
      align-items: center;
      justify-content: center;
    }
    
    .progress-bar {
      flex: 1;
      height: 4px;
      background: rgba(255,255,255,0.3);
      border-radius: 2px;
      cursor: pointer;
    }
    
    .progress {
      height: 100%;
      background: var(--secondary);
      width: 0%;
      border-radius: 2px;
    }
    
    .time {
      color: white;
      font-size: 0.9rem;
      min-width: 100px;
      text-align: center;
    }
    
    @media (max-width: 768px) {
      .full-tour-container {
        flex-direction: column;
      }
      
      .tour-description {
        padding: 1.5rem;
      }
      
      .tour-video video {
        min-height: 300px;
      }
      
      .video-controls {
        opacity: 1;
      }
    

    