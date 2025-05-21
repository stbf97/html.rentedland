
document.getElementById('petaImage').addEventListener('click', function(e) {
    const img = this;
    const rect = img.getBoundingClientRect();
    const x = (e.clientX - rect.left) / img.offsetWidth;
    const y = (e.clientY - rect.top) / img.offsetHeight;
    
    if(img.style.transform === 'scale(2)') {
      img.style.transform = 'scale(1)';
      img.style.transformOrigin = 'center center';
    } else {
      img.style.transform = 'scale(2)';
      img.style.transformOrigin = `${x * 100}% ${y * 100}%`;

      
    }
    
  });
  
  document.addEventListener('DOMContentLoaded', function () {
    const videoContainer = document.querySelector('.video-container');
    const video = videoContainer.querySelector('video');
    const playButton = document.querySelector('.play-button');
    const playPauseBtn = document.querySelector('.play-pause-btn');
    const progressBar = document.querySelector('.progress');
    const progressContainer = document.querySelector('.progress-bar');
    const timeDisplay = document.querySelector('.time');
    const fullscreenBtn = document.querySelector('.fullscreen-btn');
    const volumeBtn = document.querySelector('.volume-btn');
  
    // Big play button
    playButton.addEventListener('click', function () {
      video.play();
      videoContainer.classList.add('playing');
      playPauseBtn.innerHTML = '<i class="fas fa-pause"></i>';
    });
  
    // Play/Pause toggle
    playPauseBtn.addEventListener('click', function () {
      if (video.paused) {
        video.play();
        videoContainer.classList.add('playing');
        playPauseBtn.innerHTML = '<i class="fas fa-pause"></i>';
      } else {
        video.pause();
        playPauseBtn.innerHTML = '<i class="fas fa-play"></i>';
      }
    });
  
    // Progress bar update
    video.addEventListener('timeupdate', function () {
      const progress = (video.currentTime / video.duration) * 100;
      progressBar.style.width = progress + '%';
  
      const currentMins = Math.floor(video.currentTime / 60);
      const currentSecs = Math.floor(video.currentTime % 60).toString().padStart(2, '0');
      const durationMins = Math.floor(video.duration / 60);
      const durationSecs = Math.floor(video.duration % 60).toString().padStart(2, '0');
  
      timeDisplay.textContent = `${currentMins}:${currentSecs} / ${durationMins}:${durationSecs}`;
    });
  });
  