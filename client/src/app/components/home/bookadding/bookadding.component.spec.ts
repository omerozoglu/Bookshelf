import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BookaddingComponent } from './bookadding.component';

describe('BookaddingComponent', () => {
  let component: BookaddingComponent;
  let fixture: ComponentFixture<BookaddingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BookaddingComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BookaddingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
