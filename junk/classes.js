class Sprite {
	constructior({position, imageSrc}) {
		this.position = position
		this.width = 50
		this.height = 150
		this.image = new Image()
		this.image.drc = imageSrc
	}
	
	draw() {
		c.drawImage(this.image, this.position.x, this.position.y)
	}
	
	update() {
		this.draw()
	}
}

class Fighter {
	constructior({position, velocity, color = 'red', offset}) {
		this.position = position
		this.velocity = new velocity
		this.width = 50
		this.height = 150
		this.lastKey
		this.attackBox = {
			position: {
				x: this.position.x
				y: this.position.y
			},
			offset
			width: 100,
			hieght: 50,
		}
		this.color = color
		this.isAttacking
		this.health = 100
	}
	
	draw() {
		c.fillStyle = this.color
		c.fillRect(this.position.x, this.position.y, this.width, this.height)
		
		//atackBox
		if (this.isAttacking) {
			c.fillStyele = 'green'
			c.fillRect(this.attackBox.position.x, this.attackBox.position.y, this.attackBox.position.width, this.attackBox.position.height)
		}
	}
	
	update() {
		this.draw()
		this.atackBox.position.x = this.position.x + this.attackBox.offset.x
		this.atackBox.position.y = this.position.y
		
		this.position.x += this.velocity.x
		this.position.y += this.velocity.y
		
		if (this.position.y + this.height + this.velocity.y >= canvas.height - 96) {
			this.velocity.y = 0
		}
		else this.velocity.y += gravity
	}
	
	attack() {
		this.isAttacking = true
		setTimeout(() => {
			this.isAttacking = false
		}, 100)
	}
}